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
            
            Reservation CreateReservation = new Reservation(textBoxFirstName.Text, textBoxSecondName.Text, dateTimePickerDate.Value.ToShortDateString(), comboBoxTable.Text, 5, textBoxPhoneNumber.Text);
            string jsonString = JsonSerializer.Serialize(CreateReservation);
            File.AppendAllText(Globals.filepath, jsonString);

        }

        private void ShowReservation_Click(object sender, EventArgs e)
        {
            string jsonString = File.ReadAllText(Globals.filepath);
            Reservation ReadReservation = JsonSerializer.Deserialize<Reservation>(jsonString)!;
            Console.WriteLine(ReadReservation);

        }
    }
}