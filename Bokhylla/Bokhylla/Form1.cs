using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bokhylla
{
    
    public partial class bokhyllaForm : Form
    {
        // Skapa en lista
        Bibliotekarie bibliotekarie = new Bibliotekarie();

        private int port = 12345;
        private TcpClient client = new TcpClient();

        public bokhyllaForm()
        {
            InitializeComponent();
            client.NoDelay = true;
        }

        private void bokhyllaForm_Load(object sender, EventArgs e)
        {
            
        }

        private void bokRegis_Click(object sender, EventArgs e)
        {
            string titel = bokTiteln.Text;
            string skribent = bokSkriben.Text;
            Int32.TryParse(bokÅret.Text, out int år);
            Int32.TryParse(bokSidorna.Text, out int bokSidor);

            if (bokBarn.Checked)
            {
                ChildBok nyBok = new ChildBok(titel, år, skribent, bokSidor);

                bibliotekarie.Add(nyBok);
                bokhyllaCons.Text = "";
                bokhyllaCons.Text = "Ny bok adderades i listan: " +  nyBok.ToString();

            }
            else if (bokFakta.Checked)
            {
                FactBok nyBok = new FactBok(titel, år, skribent, bokSidor);

                bibliotekarie.Add(nyBok);
                bokhyllaCons.Text = "";
                bokhyllaCons.Text = "Ny bok adderades i listan: " + nyBok.ToString();
            }
            else
            {
                NovelBok nyBok = new NovelBok(titel, år, skribent, bokSidor);

                bibliotekarie.Add(nyBok);
                bokhyllaCons.Text = "";
                bokhyllaCons.Text = "Ny bok adderades i listan: " + nyBok.ToString();
            }

            
            // Rensa formuläret
            bokTiteln.Text = "";
            bokSkriben.Text = "";
            bokÅret.Text = "";
            bokSidorna.Text = "";

            // Uppdatera Listan
            lbxList.Items.Clear();
            string[] input = bibliotekarie.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string item in input)
            {
                lbxList.Items.Add(item);
            }
        }

        private void tidsRegi_Click(object sender, EventArgs e)
        {
            string titel = tidsTiteln.Text;
            Int32.TryParse(tidsÅret.Text, out int år);
            Int32.TryParse(tidsNummeret.Text, out int nummer);

            if (tidsFritid.Checked)
            {
                Leisure nyTids = new Leisure(titel, år, nummer);

                bibliotekarie.Add(nyTids);
                bokhyllaCons.Text = "";
                bokhyllaCons.Text = "Ny tidskrift adderades i listan: " + nyTids.ToString();
            }
            else if (tidsMusik.Checked)
            {
                Music nyTids = new Music(titel, år, nummer);

                bibliotekarie.Add(nyTids);
                bokhyllaCons.Text = "";
                bokhyllaCons.Text = "Ny tidskrift adderades i listan: " + nyTids.ToString();
            }
            else
            {
                Comics nyTids = new Comics(titel, år, nummer);

                bibliotekarie.Add(nyTids);
                bokhyllaCons.Text = "";
                bokhyllaCons.Text = "Ny tidskrift adderades i listan: " + nyTids.ToString();
            }
            
            // Rensa formuläret
            tidsTiteln.Text = "";
            tidsÅret.Text = "";
            tidsNummeret.Text = "";

            // Uppdatera Listan
            lbxList.Items.Clear();
            string[] input = bibliotekarie.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string item in input)
            {
                lbxList.Items.Add(item);
            }
        }

        private void btnSearchBibliot_Click(object sender, EventArgs e)
        {
            if (rdbYearBibliot.Checked)
            {
                Int32.TryParse(txbSearchBibliot.Text, out int key);
                bokhyllaCons.Text = "";
                bokhyllaCons.Text = bibliotekarie.SearchResult(key);
            }
            else
            {
                bokhyllaCons.Text = "";
                bokhyllaCons.Text = bibliotekarie.SearchResult(txbSearchBibliot.Text);
            }
        }

        private void btnTaBortBibliot_Click(object sender, EventArgs e)
        {
            string key = txbSearchBibliot.Text;
            if (rdbYearBibliot.Checked)
            {
                Int32.TryParse(key, out int year);
                bibliotekarie.Remove(year);
            }
            else
            {
                bibliotekarie.Remove(key);
            }

            bokhyllaCons.Text = "";
            bokhyllaCons.Text = bibliotekarie.ToString();
        }

        private void lblSearchBibliot_Click(object sender, EventArgs e)
        {

        }

        private void btnKlientKoppla_Click(object sender, EventArgs e)
        {
            IPAddress serverIP = IPAddress.Parse("127.0.0.1");
            StartConnection(serverIP);
        }

        private async void StartConnection(IPAddress serverIP)
        {
            try
            {
                await client.ConnectAsync(serverIP, port);
                btnKlientKoppla.BackColor = Color.LightGreen;
                btnKlientKoppla.Text = "Server kopplats";
                btnKlientAlla.Enabled = true;
                btnKlientMark.Enabled = true;
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, this.Text);
                return;
            }
        }

        private void btnKlientLadda_Click(object sender, EventArgs e)
        {
            string file = "texter.txt";

            try
            {
                bibliotekarie = new Bibliotekarie(file);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, this.Text);
                return;
            }            

            grupBok.Enabled = true;
            grupTids.Enabled = true;
            grbBibliotekare.Enabled = true;

            string[] input = bibliotekarie.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (string item in input)
            {
                lbxList.Items.Add(item);
            }

            btnKlientLadda.Enabled = false;

        }

        private void btnKlientMark_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] message = Encoding.Unicode.GetBytes(bibliotekarie.StringByIndex(lbxList.SelectedIndex));
                StartSending(message);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, this.Text);
                return;
            }

            
        }

        private void btnKlientAlla_Click(object sender, EventArgs e)
        {
            byte[] message = Encoding.Unicode.GetBytes(bibliotekarie.StringToServer());
            StartSending( message );
        }

        private async void StartSending(byte[] message)
        {
            try
            {
                await client.GetStream().WriteAsync(message, 0, message.Length);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, this.Text);
                return;
            }

            bokhyllaCons.Text = "List sent till server.";
        }
    }

    //----------------------------------------------------------------------------------------------------------//
    //------------------------------------------------CLASS LIST------------------------------------------------//
    //----------------------------------------------------------------------------------------------------------//

    // Grund Class för både böcker och tidskrifter
    public class Media
    {
        public Media() { }

        public Media(string titel, int year)
        {
            this.Titel = titel;
            this.Year = year;
        }

        public string Titel { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public string Author { get; set; }
        public int TotalPages { get; set; }
        public int Number { get; set; }

        public virtual string StringToServer() { return ""; }
    }

    // ------------------------ Class Bok ------------------------
    public abstract class Book : Media
    {
        public Book(string titel, int year, string author, int totalPages) : base(titel, year)
        {
            this.Author = author;
            this.TotalPages = totalPages;
        }
    }

    class ChildBok : Book
    {
        public ChildBok(string titel, int year, string author, int totalPages) : base(titel, year, author, totalPages)
        {
            // Redigera typ
            Type = "BarnBok";
        }

        public override string StringToServer()
        {
            return Titel + "###" + Author + "###" + Year + "###" + TotalPages + "###" + Type + " , ";
        }

        // Skriv ut
        public override string ToString()
        {
            return Titel + ", " + Author + ". År: " + Year + ". Antal sidor:  " + TotalPages + ". (" + Type + ")";
        }

        
    }

    class FactBok : Book
    {
        public FactBok(string titel, int year, string author, int totalPages) : base(titel, year, author, totalPages)
        {
            // Redigera typ
            Type = "Fakta";
        }

        public override string StringToServer()
        {
            return Titel + "###" + Author + "###" + Year + "###" + TotalPages + "###" + Type + " , ";
        }

        // Skriv ut
        public override string ToString()
        {
            return Titel + ", " + Author + ". År: " + Year + ". Antal sidor: " + TotalPages + ". (" + Type + ")";
        }
    }

    class NovelBok : Book
    {
        public NovelBok(string titel, int year, string author, int totalPages) : base(titel, year, author, totalPages)
        {
            // Redigera typ
            Type = "Roman";
        }

        public override string StringToServer()
        {
            return Titel + "###" + Author + "###" + Year + "###" + TotalPages + "###" + Type + " , ";
        }

        // Skriv ut
        public override string ToString()
        {
            return Titel + ", " + Author + ". År: " + Year + ". Antal sidor:  " + TotalPages + ". (" + Type + ")";
        }
    }

    // ------------------------ Class Tidskrift ------------------------
    public abstract class Magazine : Media
    {
        public Magazine(string titel, int year, int number) : base(titel, year)
        {
            this.Number = number;
        }
    }

    class Leisure : Magazine
    {
        public Leisure(string titel, int year, int number) : base(titel, year, number)
        {
            // Redigera typ
            Type = "Fritid";
        }

        public override string StringToServer()
        {
            return Titel + "###" + Number + "###" + Year + "###" + Type + " , ";
        }

            // Skriv ut
            public override string ToString()
        {
            return Titel + ". N" + Number + "/" + Year + ". (" + Type + ")";
        }
    }

    class Music : Magazine
    {
        public Music(string titel, int year, int number) : base(titel, year, number)
        {
            // Redigera typ
            Type = "Musik";
        }

        public override string StringToServer()
        {
            return Titel + "###" + Number + "###" + Year + "###" + Type + " , ";
        }

        // Skriv ut
        public override string ToString()
        {
            return Titel + ". N" + Number + "/" + Year + ". (" + Type + ")";
        }
    }

    class Comics : Magazine
    {
        public Comics(string titel, int year, int number) : base(titel, year, number)
        {
            // Redigera typ
            Type = "Comics";
        }

        public override string StringToServer()
        {
            return Titel + "###" + Number + "###" + Year + "###" + Type + " , ";
        }

        // Skriv ut
        public override string ToString()
        {
            return Titel + ". N" + Number + "/" + Year + ". (" + Type + ")";
        }
    }

    // ------------------------ Class Biliotekarie ------------------------
    class Bibliotekarie
    {
        private List<Media> bokList = new List<Media>();

        public Bibliotekarie() { }

        public Bibliotekarie(string file)
        {
            // Laddar en standart lista 
            StreamReader reader = new StreamReader(file, Encoding.Default, true);
            string text = reader.ReadToEnd();
            string[] words = text.Split(new string[] { "###", "\r\n" }, StringSplitOptions.None);

            for (int i = 0; i < words.Count(); i++)
            {
                string result = words[i];

                switch (result)
                {
                    case "Barn":

                        Int32.TryParse(words[i + 2], out int yearC);
                        Int32.TryParse(words[i + 4], out int pagesC);

                        bokList.Add(new ChildBok(words[i + 1], yearC, words[i + 3], pagesC));

                        i += 4;

                        break;

                    case "Fakta":

                        Int32.TryParse(words[i + 2], out int yearF);
                        Int32.TryParse(words[i + 4], out int pagesF);

                        bokList.Add(new FactBok(words[i + 1], yearF, words[i + 3], pagesF));

                        i += 4;

                        break;

                    case "Roman":

                        Int32.TryParse(words[i + 2], out int yearR);
                        Int32.TryParse(words[i + 4], out int pagesR);

                        bokList.Add(new NovelBok(words[i + 1], yearR, words[i + 3], pagesR));

                        i += 4;

                        break;

                    case "Fritid":

                        Int32.TryParse(words[i + 2], out int yearFr);
                        Int32.TryParse(words[i + 3], out int numberFr);

                        bokList.Add(new Leisure(words[i + 1], yearFr, numberFr));

                        i += 3;

                        break;

                    case "Musik":

                        Int32.TryParse(words[i + 2], out int yearL);
                        Int32.TryParse(words[i + 3], out int numberL);

                        bokList.Add(new Music(words[i + 1], yearL, numberL));

                        i += 3;

                        break;

                    case "Comics":

                        Int32.TryParse(words[i + 2], out int yearCo);
                        Int32.TryParse(words[i + 3], out int numberCo);

                        bokList.Add(new Comics(words[i + 1], yearCo, numberCo));

                        i += 3;

                        break;

                    default:
                        break;
                }
            }

            Sortera();
        }

        // Addera en ny bok i listan
        public void Add(Media m)
        {
            bokList.Add(m);
            Sortera();
        }

        // Kolla på om det är en bok (String)
        public bool Bok(string titel)
        {
            // Sökning algoritm
            int index = this.Search(titel);

            bool resultBok = true;

            if (index < 0)
            {
                resultBok = false;
            }
            else
            {
                int barn = bokList[index].Type.CompareTo("Barn");
                int fakta = bokList[index].Type.CompareTo("Fakta");
                int roman = bokList[index].Type.CompareTo("Roman");

                if (barn == 0 || fakta == 0 || roman == 0)
                {
                    resultBok = true;
                }
                else
                {
                    resultBok = false;
                }
            }          

            return resultBok;
        }

        // Kolla på om det är en bok (Int)
        public bool Bok(int key)
        {
            // Sökning algoritm
            int index = this.Search(key);

            bool resultBok = true;

            if (index < 0)
            {
                resultBok = false;
            }
            else
            {
                int barn = bokList[index].Type.CompareTo("Barn");
                int fakta = bokList[index].Type.CompareTo("Fakta");
                int roman = bokList[index].Type.CompareTo("Roman");

                if (barn == 0 || fakta == 0 || roman == 0)
                {
                    resultBok = true;
                }
                else
                {
                    resultBok = false;
                }
            }

            return resultBok;
        }

        // Kolla på om det är en tidskrift (String)
        public bool Tids(string titel)
        {
            // Sökning algoritm
            int index = this.Search(titel);

            bool resultTids = true;

            if (index < 0)
            {
                resultTids = false;
            }
            else
            {
                int fritid = bokList[index].Type.CompareTo("Fritid");
                int musik = bokList[index].Type.CompareTo("Musik");
                int comics = bokList[index].Type.CompareTo("Comics");

                if (fritid == 0 || musik == 0 || comics == 0)
                {
                    resultTids = true;
                }
                else
                {
                    resultTids = false;
                }
            }

            return resultTids;
        }

        // Kolla på om det är en tidskrift (Int)
        public bool Tids(int key)
        {
            // Sökning algoritm
            int index = this.Search(key);

            bool resultTids = true;

            if (index < 0)
            {
                resultTids = false;
            }
            else
            {
                int fritid = bokList[index].Type.CompareTo("Fritid");
                int musik = bokList[index].Type.CompareTo("Musik");
                int comics = bokList[index].Type.CompareTo("Comics");

                if (fritid == 0 || musik == 0 || comics == 0)
                {
                    resultTids = true;
                }
                else
                {
                    resultTids = false;
                }
            }

            return resultTids;
        }
        
        // Kasta bort en bok i listan (String)
        public void Remove(string titel)
        {
            // Sökning algoritm
            int index = this.Search(titel);

            if (index >= 0)
            {
                int compare = titel.CompareTo(bokList[index].Titel);

                if (compare == 0)
                {
                    bokList.Remove(bokList[index]);
                }
            }                                
        }

        // Kasta bort en bok i listan (Int)
        public void Remove(int key)
        {
            // Sökning algoritm
            int index = this.Search(key);

            if (index >= 0 && bokList[index].Year == key)
            {
                bokList.Remove(bokList[index]);
            }
        }

        // Sökning algoritmer (INT)
        public int Search(int key)
        {
            // Sökning algoritm
            int first = 0;
            int last = bokList.Count - 1;
            int result = 0;

            while (first <= last)
            {
                int mid = (first + last) / 2;

                if (key > bokList[mid].Year)
                {
                    first = mid + 1;
                }
                else if (key < bokList[mid].Year)
                {
                    last = mid - 1;
                }
                else
                {
                    result = mid;
                    break;
                }
            }

            if (bokList[result].Year == key)
            {
                return result;
            }
            else
            {
                return -1;
            }              
        }

        // Sökning algoritmer (String)
        public int Search(string titel)
        {
            // Sökning algoritm
            int first = 0;
            int last = bokList.Count - 1;
            int result = 0;

            while (first <= last)
            {
                int mid = (first + last) / 2;

                int key = titel.CompareTo(bokList[mid].Titel);

                if (key > 0)
                {
                    first = mid + 1;
                }
                else if (key < 0)
                {
                    last = mid - 1;
                }
                else
                {
                    result = mid;
                    break;
                }
            }

            int compare = titel.CompareTo(bokList[result].Titel);

            if (compare == 0)
            {
                return result;
            }
            else
            {
                return -1;
            }
        }

        // Sökning result (String)
        public string SearchResult(string titel)
        {
            string message = "";

            int index = this.Search(titel);

            if (index < 0)
            {
                message = "Det finns ingen bok eller tidskrift som heter " + titel;
            }
            else
            {
                message = bokList[index].ToString();
            }

            return message;
        }

        // Sökning result (INT)
        public string SearchResult(int key)
        {
            string message = "";

            int index = this.Search(key);

            if (index < 0)
            {
                message = "Det finns ingen bok eller tidskrift som publicerats i " + key;
            }
            else
            {
                message = bokList[index].ToString();
            }

            return message;
        }

        // Sortera listan
        private void Sortera()
        {
            // Bubblesort Algoritm
            int max = bokList.Count - 1;

            for (int i = 0; i < max; i++)
            {
                int nrLeft = max - 1;

                for (int j = 0; j <= nrLeft; j++)
                {
                    int value = bokList[j].Titel.CompareTo(bokList[j + 1].Titel);

                    if (value > 0)
                    {
                        Media temp = new Media();
                        temp = bokList[j];
                        bokList[j] = bokList[j + 1];
                        bokList[j + 1] = temp;
                    }
                }
            }
        }

        public string StringByIndex(int index)
        {
            return bokList[index].StringToServer();
        }

        public string StringToServer()
        {
            string lista = "";

            foreach (var n in bokList)
            {
                lista += n.StringToServer();
            }

            return lista;
        }

        // Skriva ut alla lista
        public override string ToString()
        {
            string lista = "";

            foreach (var n in bokList)
            {
                lista += n.ToString() + Environment.NewLine;
            }

            return lista;
        }
    }
}
