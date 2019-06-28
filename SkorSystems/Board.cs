using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mario.Class.FileProces
{
    class Board
    {
        public List<ScoreItem> Items = new List<ScoreItem>();//Metin belgesinde verileri obje olarak tutan list
        List<string> FileData = new List<string>();//Metn belgesinden çekilen verilerinin tutulduğu list

        public Board()//ctor
        {
            //Relative Path
            string ExeDosyaYolu = Application.StartupPath.ToString();
            string filePath = ExeDosyaYolu + "\\contact.txt";
            FieldBoard(filePath);
        }
        public Board(String path)//Özel path verilirse
        {
            string filePath = @path;
            FieldBoard(filePath);
        }
        public void FieldBoard(string filePath)//Metin belgesinden veriler çekip ScoreService Sınıfınn methotlarının kullanarak ScoreItemListe nesneleri atar
        {
            FileRead(filePath);
            foreach (string data in FileData)
            {
                string[] strArray;
                strArray = data.Split(' ');//metin belgesinde veriler boşulukla yazılığı için "ali 890" gibi
                ScoreService create = new ScoreService();
                Items.Add(create.CreateScoreItemNew(strArray[0], Convert.ToInt32(strArray[1])));
            }
        }
        public void FileRead(String FilePath)//dosya okuma
        {
            StreamReader reader;
            reader = File.OpenText(FilePath);
            string item;

            while ((item = reader.ReadLine()) != null)
            {
                FileData.Add(item);
            }
            reader.Close();
        }
        public void SortByName()//isme göre sıralama
        {
            this.Items = Items.OrderBy(item => item.Name).ToList();
        }
        public void SortByScore()//Skora göre sıralama
        {
            this.Items = Items.OrderByDescending(item => item.Score).ToList();
        }
        public List<ScoreItem> Top10()//En yüksek 10 Puanlık nesneleri bir liste atıp o listeyi döndüren fonk
        {
            this.SortByScore();
            List<ScoreItem> ItemsTop = Items.GetRange(0,9);
            return ItemsTop;
        }
    }
}
