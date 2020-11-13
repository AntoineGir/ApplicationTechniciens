using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTechniciens.ModelLayer.Business
{
    class Reservation
    {
        private DateTime date;
        private int id;
        private int idClient;
        private int idSalle;
        private int Prix;
        private int idTechnicien;
        private int ordreobstacle;
        private int NbClient;
        private int idtheme;

        public DateTime Date { get => date; set => date = value; }
        public int Id { get => id; set => id = value; }
        public int IdClient { get => idClient; set => idClient = value; }
        public int IdSalle { get => idSalle; set => idSalle = value; }
        public int Prix1 { get => Prix; set => Prix = value; }
        public int IdTechnicien { get => idTechnicien; set => idTechnicien = value; }
        public int Ordreobstacle { get => ordreobstacle; set => ordreobstacle = value; }
        public int NbClient1 { get => NbClient; set => NbClient = value; }
        public int Idtheme { get => idtheme; set => idtheme = value; }

        public Reservation()
        { }
    }
}
