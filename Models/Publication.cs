using System;
using System.Collections.Generic;
using System.Text;

namespace LemmaApp.Models
{
    public class Publication
    {

        /*public int id { get; set; }
        public int id_user { get; set; }
        public int id_famille { get; set; }*/
        public string description { get; set; }
        public DateTime date_post { get; set; }

        public int var { get; set; }
        public string imgUrl { get; set; }

        public List<Publication> getPub()
        {
            List<Publication> pubs = new List<Publication>
            {
                new Publication() {description="description1", date_post=DateTime.Now, var=0, imgUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRTWg_U0HGK7FIS7PCxqbRSmuZBpcebJepQeGig4xn2PDNuptyrqr0z2M64nw"},
                new Publication() {description="description1", date_post=DateTime.Now, var=0, imgUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRTWg_U0HGK7FIS7PCxqbRSmuZBpcebJepQeGig4xn2PDNuptyrqr0z2M64nw"},
                new Publication() {description="description1", date_post=DateTime.Now, var=0, imgUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRTWg_U0HGK7FIS7PCxqbRSmuZBpcebJepQeGig4xn2PDNuptyrqr0z2M64nw"},
                new Publication() {description="description1", date_post=DateTime.Now, var=0, imgUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRTWg_U0HGK7FIS7PCxqbRSmuZBpcebJepQeGig4xn2PDNuptyrqr0z2M64nw"},
                new Publication() {description="description1", date_post=DateTime.Now, var=0, imgUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRTWg_U0HGK7FIS7PCxqbRSmuZBpcebJepQeGig4xn2PDNuptyrqr0z2M64nw"},
                new Publication() {description="description1", date_post=DateTime.Now, var=0, imgUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRTWg_U0HGK7FIS7PCxqbRSmuZBpcebJepQeGig4xn2PDNuptyrqr0z2M64nw"},
                new Publication() {description="description1", date_post=DateTime.Now, var=0, imgUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRTWg_U0HGK7FIS7PCxqbRSmuZBpcebJepQeGig4xn2PDNuptyrqr0z2M64nw"},
                new Publication() {description="description1", date_post=DateTime.Now, var=0, imgUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRTWg_U0HGK7FIS7PCxqbRSmuZBpcebJepQeGig4xn2PDNuptyrqr0z2M64nw"},
                new Publication() {description="description1", date_post=DateTime.Now, var=0, imgUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRTWg_U0HGK7FIS7PCxqbRSmuZBpcebJepQeGig4xn2PDNuptyrqr0z2M64nw"},
                new Publication() {description="description1", date_post=DateTime.Now, var=0, imgUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRTWg_U0HGK7FIS7PCxqbRSmuZBpcebJepQeGig4xn2PDNuptyrqr0z2M64nw"},
                new Publication() {description="description1", date_post=DateTime.Now, var=0, imgUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRTWg_U0HGK7FIS7PCxqbRSmuZBpcebJepQeGig4xn2PDNuptyrqr0z2M64nw"},
                new Publication() {description="description1", date_post=DateTime.Now, var=0, imgUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRTWg_U0HGK7FIS7PCxqbRSmuZBpcebJepQeGig4xn2PDNuptyrqr0z2M64nw"},
                new Publication() {description="description1", date_post=DateTime.Now, var=0, imgUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRTWg_U0HGK7FIS7PCxqbRSmuZBpcebJepQeGig4xn2PDNuptyrqr0z2M64nw"},
                new Publication() {description="description1", date_post=DateTime.Now, var=0, imgUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRTWg_U0HGK7FIS7PCxqbRSmuZBpcebJepQeGig4xn2PDNuptyrqr0z2M64nw"},
                new Publication() {description="description1", date_post=DateTime.Now, var=0, imgUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRTWg_U0HGK7FIS7PCxqbRSmuZBpcebJepQeGig4xn2PDNuptyrqr0z2M64nw"},
                new Publication() {description="description1", date_post=DateTime.Now, var=0, imgUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRTWg_U0HGK7FIS7PCxqbRSmuZBpcebJepQeGig4xn2PDNuptyrqr0z2M64nw"},

            };
            return pubs;
        }
    }
}

    
