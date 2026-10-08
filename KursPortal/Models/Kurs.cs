namespace KursPortal.Models
{
    public class Kurs
    {
        public int Id { get; set; }
        public string Kursname { get; set; }
        public string Dozent { get; set; }
        public int AnzahlTeilnehmer { get; set; }
        public int DauerInTagen { get; set; }
        public string Inhalt { get; set; }
    }
}
