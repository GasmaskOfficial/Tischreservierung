using System;
using System.IO;
using System.Linq;
//using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Text;
//using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Tischreservierung
{
    public partial class Tischreservierung : Form
    {
        public Tischreservierung()
        {
            InitializeComponent();
        }

        static class Globals
        {
            public static string filepath = "C:\\TEMP\\Reservierungen.txt";
        }

        private void ReserveTable_Click(object sender, EventArgs e)
        {
                
            if (!File.Exists(Globals.filepath))
            {
                var CreateFile = File.Create(Globals.filepath);
                CreateFile.Close();
                File.WriteAllText(Globals.filepath, "[");
                MessageBox.Show("Eine neue Datei wurde erstellt");
            }
            else
            { 
            
                if (new FileInfo(Globals.filepath).Length == 1)
                {
                    Reservation CreateReservation = new Reservation(textBoxFirstName.Text, textBoxSecondName.Text, dateTimePickerDate.Value.ToShortDateString(), comboBoxTable.Text, 5, textBoxPhoneNumber.Text);
                    string jsonString = JsonSerializer.Serialize(CreateReservation);
                    File.AppendAllText(Globals.filepath, jsonString);
                    File.AppendAllText(Globals.filepath, "]");
                    MessageBox.Show("Die Reservierung wurde erfolgreich erstellt!");
                }

                else
                {
                    string jsonStringRead = File.ReadAllText(Globals.filepath);
                    var ReservationList = JsonSerializer.Deserialize<List<Reservation>>(jsonStringRead);
                    Reservation CreateReservation = new Reservation(textBoxFirstName.Text, textBoxSecondName.Text, dateTimePickerDate.Value.ToShortDateString(), comboBoxTable.Text, 5, textBoxPhoneNumber.Text);
                    ReservationList.Add(CreateReservation); 
                    string jsonStringWrite = JsonSerializer.Serialize(ReservationList);
                    File.WriteAllText(Globals.filepath, jsonStringWrite);
                    MessageBox.Show("Die Reservierung wurde erfolgreich erstellt!");
                }
            }

        }

        private void ShowReservation_Click(object sender, EventArgs e)
        {
            string jsonString = File.ReadAllText(Globals.filepath);
            var ReservationList = JsonSerializer.Deserialize<List<Reservation>>(jsonString);
            Console.WriteLine(ReservationList);
            
        }
    }
}