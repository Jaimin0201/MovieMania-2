using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MovieMania.Models;


namespace MovieMania.Data
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<MovieManiaContext>
    {
        protected override void Seed(MovieManiaContext context)
        {
            //  context.Users.Add(new User
            //  {
            //      FirstName = "Marcelo",
            //      LastName = "Ferreira Cavaliere",
            //      DOB = DateTime.Parse("04/02/1988"),
            //     email = "marcelocavaliere@gmail.com",
            //       Password = "123456",
            //       UnitNum = 5,
            //       StreetNum = 100,
            //       StreetName = "O'Brien st",
            //       Complement = "",
            //       Suburb = "Bondi Beach",
            //       City = "Sydney",
            //       State = "NSW",
            //       Country = "Australia",
            //       PreferredName = "Marcelo Cavaliere"
            //   });
            context.Users.Add(new User
            {
                FirstName = "Elaine Cristina",
                LastName = "Ferreira De Lima",
                DOB = DateTime.Parse("04/01/1986"),
                email = "elainelima_18@gmail.com",
                Password = "123456",
                UnitNum = 5,
                StreetNum = 100,
                StreetName = "O'Brien st",
                Complement = "",
                Suburb = "Bondi Beach",
                City = "Sydney",
                State = "NSW",
                Country = "Australia",
                PreferredName = "Elaine Lima"

            });
            context.Users.Add(new User
            {
                FirstName = "Giuseppe",
                LastName = "Cavaliere",
                DOB = DateTime.Parse("28/04/1958"),
                email = "giuseppecavaliere@gmail.com",
                Password = "123456",
                UnitNum = 5,
                StreetNum = 100,
                StreetName = "O'Brien st",
                Complement = "",
                Suburb = "Bondi Beach",
                City = "Sydney",
                State = "NSW",
                Country = "Australia",
                PreferredName = "Giuseppe Cavaliere"

            });

            context.Plans.Add(new Plan
            {
                Name = "Plan_Movies",
                Price = 5.00m

            });

            context.Plans.Add(new Plan
            {
                Name = "Plan_Series",
                Price = 7.00m

            });

            context.Plans.Add(new Plan
            {
                Name = "Plan_Series&Movies",
                Price = 10.00m

            });

            context.Series.Add(new Serie
            {
                SerieTitle = "The Walking Dead",
                SerieDescription = "In the wake of a zombie apocalypse, various survivors struggle to stay alive." +
                " As they search for safety and evade the undead, they are forced to grapple with rival groups and difficult choices.",
                FilePath = "images/TheWalkingDeadCover.jpg",
                SeasonsNumber = 10


            });


            context.Series.Add(new Serie
            {
                SerieTitle = "Loki",
                SerieDescription = "Loki, the God of Mischief, steps out of his brother's shadow to embark on an " +
                "adventure that takes place after the events of 'Avengers: Endgame.'",
                FilePath = "images/Loki.jpg",
                SeasonsNumber = 1

            });

            context.Movies.Add(new Movie
            {
                MovieTitle = "Avatar",
                DurationHours = 1,
                DurationMin = 30,
                ReleaseDate = DateTime.Parse("17/12/2009"),
                Description = "Jake, who is paraplegic, replaces his twin on the Na'vi inhabited Pandora" +
                " for a corporate mission. After the natives accept him as one of their own, " +
                "he must decide where his loyalties lie.",
                FilePath = "images/Avatar.jpg",

            });

            context.Movies.Add(new Movie
            {
                MovieTitle = "Titanic",
                DurationHours = 1,
                DurationMin = 30,
                ReleaseDate = DateTime.Parse("17/12/1997"),
                Description = "RMS Titanic was a British passenger liner operated by the White Star Line " +
                "that sank in the North Atlantic Ocean on 15 April 1912, after striking an iceberg during " +
                "her maiden voyage from Southampton to New York City.",
                FilePath = "images/Titanic.jpg",

            });

            context.Movies.Add(new Movie
            {
                MovieTitle = "Indiana Jones - Raiders of the Lost Ark",
                DurationHours = 1,
                DurationMin = 30,
                ReleaseDate = DateTime.Parse("14/08/1981"),
                Description = "Archaeology professor Indiana Jones ventures to seize a biblical " +
                "artefact known as the Ark of the Covenant. While doing so, he puts up a fight " +
                "against Renee and a troop of Nazis.",
                FilePath = "images/IndianaJones-RaidersOfTheLostArk.jpg",

            });

            context.Genres.Add(new Genre
            {
                Name = "Genre1",
                Description = "Description1"

            });

            context.Genres.Add(new Genre
            {
                Name = "Genre2",
                Description = "Description2"

            });
            context.Genres.Add(new Genre
            {
                Name = "Genre3",
                Description = "Description3"

            });

            context.Episodes.Add(new Episode
            {
                Title = "Days Gone Bye",
                SerieName = "The Walking Dead",
                SeasonNumber = 1,
                EpisodeNumber = 1,
                DurationHours = 1,
                DurationMin = 0,
                ReleaseDate = DateTime.Parse("10/08/2020"),
                Description = "Sheriff's deputy Rick Grimes wakes from a gunshot-inflicted coma to discover " +
                "the world overrun with walkers. He goes back to his house to try and find his wife and son but" +
                " meets survivor Morgan Jones and his son Duane. Rick decides to head to Atlanta to find his wife " +
                "Lori and son Carl, unaware they are safe with other survivors, led by his former partner Shane. " +
                "He encounters hordes of walkers and becomes trapped inside a tank."

            });

            context.Episodes.Add(new Episode
            {
                Title = "Guts",
                SerieName = "The Walking Dead",
                SeasonNumber = 1,
                EpisodeNumber = 2,
                DurationHours = 0,
                DurationMin = 40,
                ReleaseDate = DateTime.Parse("11/08/2020"),
                Description = "Rick is ambushed by a walker horde but is rescued by scavenger survivor Glenn when he becomes " +
                "trapped inside a tank. They meet up with the rest of the survivors where they have to leave Merle handcuffed" +
                " to the roof to stop him attracting walkers. They are forced to leave Rick's gun bag behind as well as abandon" +
                " the unhinged Merle as walkers surround them, but manage to escape the city."
            });

            context.Episodes.Add(new Episode
            {
                Title = "Tell It to the Frogs",
                SerieName = "The Walking Dead",
                SeasonNumber = 1,
                EpisodeNumber = 3,
                DurationHours = 0,
                DurationMin = 42,
                ReleaseDate = DateTime.Parse("15/10/2020"),
                Description = "Glenn takes Rick to the survivors' camp, where he finds Lori, Carl, and Shane." +
                " Rick leads a group, including Glenn, T-Dog, and Merle's younger brother, Daryl back to Atlanta " +
                "to recover his weapons, finding that Merle managed to free himself by sawing off his hand."
            });
            context.Episodes.Add(new Episode
            {
                Title = "Loki ep1",
                SerieName = "Loki",
                SeasonNumber = 1,
                EpisodeNumber = 1,
                DurationHours = 1,
                DurationMin = 0,
                ReleaseDate = DateTime.Parse("10/11/2020"),
                Description = "desc loki 1."

            });

            context.Episodes.Add(new Episode
            {
                Title = "Loki ep2",
                SerieName = "Loki",
                SeasonNumber = 1,
                EpisodeNumber = 2,
                DurationHours = 0,
                DurationMin = 46,
                ReleaseDate = DateTime.Parse("11/12/2020"),
                Description = "desc loki 2."
            });





            base.Seed(context);
        }
    }
}