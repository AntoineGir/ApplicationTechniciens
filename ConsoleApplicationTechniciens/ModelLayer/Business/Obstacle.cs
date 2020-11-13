using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTechniciens.ModelLayer.Business
{
    class Obstacle
    {
        private int id;
        private string nom;
        private string photo;
        private string commentaire;
        private int difficulte;
        private float prix;
        private string theme;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Photo { get => photo; set => photo = value; }
        public string Commentaire { get => commentaire; set => commentaire = value; }
        public int Difficulte { get => difficulte; set => difficulte = value; }
        public float Prix { get => prix; set => prix = value; }
        public string Theme { get => theme; set => theme = value; }

        public Obstacle()
        {}

        public Obstacle(int Id, string Nom, string Photo, string Commentaire, int Difficulte, float Prix, string Theme)
        {
            id = Id;
            nom = Nom;
            photo = Photo;
            commentaire = Commentaire;
            difficulte = Difficulte;
            prix = Prix;
            theme = Theme;
        }


    }
}
