using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GrunderArvObjekt
{
    internal class FilmListan
    {
        //Skapa en klass som heter movie
        public class Movie
        {
            //Skapa propertys
            public string Name { get; set; }
            public string Director { get; set; }
            public DateOnly ReleaseDate { get; set; }
            public int LengthInMinutes { get; set; }
            public bool SuitableForChildren { get; set; } = true;
            public string[] Stars { get; set; }


            //Konstruktor
            public Movie(string name, string director, DateOnly releaseDate, int lengthInMinutes, bool suitableForChildren, string[] stars)
            {
                Name = name;
                Director = director;
                ReleaseDate = releaseDate;
                LengthInMinutes = lengthInMinutes; 
                SuitableForChildren = suitableForChildren;
                Stars = stars;
            }



            //Skapa en metod som bygger berättelsen
            public string BuildStory()
            {
                return (Name) + " är en film som regisserats av " + Director + " med premiär " + ReleaseDate + " och är " + LengthInMinutes + ".";
            }

        }


       
    }



}
