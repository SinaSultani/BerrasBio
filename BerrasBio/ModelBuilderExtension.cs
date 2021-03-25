using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BerrasBio.Models;
using Microsoft.EntityFrameworkCore;

namespace BerrasBio
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(

                new Movie
                {
                    Id = 1,
                    MovieName = "Titanic",
                    Genre = "Romantic"
                },
                new Movie
                {
                    Id=2,
                    MovieName = "The Hateful Eight",
                    Genre = "Crime"
                },
                new Movie
                {
                    Id=3,
                    MovieName = "Catch Me If You Can",
                    Genre = "Biography"
                },
                 new Movie
                 {
                     Id=4,
                     MovieName = "The Conjuring",
                     Genre = "Horror"
                 },
                 new Movie
                 {
                     Id=5,
                     MovieName = "Tenet",
                     Genre = "Action"
                 },
                 new Movie
                 {
                     Id=6,
                     MovieName = "Min Pappa Marianne",
                     Genre = "Drama"
                 },
                 new Movie
                 {
                     Id=7,
                     MovieName = "American Pie",
                     Genre = "Comedy"
                 },
                 new Movie
                 {
                     Id=8,
                     MovieName = "Parasit",
                     Genre = "Thriller"
                 },
                 new Movie
                 {
                     Id=9,
                     MovieName = "Mamma Mia!",
                     Genre = "Romantic"
                 },
                 new Movie
                 {
                     Id=10,
                     MovieName = "Avengers",
                     Genre = "Sci-Fi"
                 },
                 new Movie
                 {
                     Id=11,
                     MovieName = "Det Sociala Arvet",
                     Genre = "Documentary"
                 },
                 new Movie
                 {
                     Id=12,
                     MovieName = "The Conjuring 2",
                     Genre = "Horror"
                 },
                 new Movie
                 {
                     Id=13,
                     MovieName = "Searching for Sugar Man",
                     Genre = "Documentary"
                 },
                 new Movie
                 {
                     Id=14,
                     MovieName = "John Wick",
                     Genre = "Thriller"
                 },
                 new Movie
                 {
                     Id=15,
                     MovieName = "The Invisible Man",
                     Genre = "Sci-Fi"
                 },
                 new Movie
                 {
                     Id=16,
                     MovieName = "Joker",
                     Genre = "Drama"
                 },
                new Movie
                {
                    Id=17,
                    MovieName = "Get Out",
                    Genre = "Horror"
                },
                new Movie
                {
                    Id=18,
                    MovieName = "The Revenant",
                    Genre = "Thriller"
                },
                 new Movie
                 {
                     Id=19,
                     MovieName = "Manchester By The Sea",
                     Genre = "Drama"
                 },
                 new Movie
                 {
                     Id=20,
                     MovieName = "La La Land",
                     Genre = "Musical"
                 },
                 new Movie
                 {
                     Id=21,
                     MovieName = "The Big Short",
                     Genre = "Drama"
                 },
                 new Movie
                 {
                     Id=22,
                     MovieName = "Toy Story",
                     Genre = "Family"
                 },
                 new Movie
                 {
                     Id=23,
                     MovieName = "Three Billboards Outside Ebbing, Missouri",
                     Genre = "Crime"
                 },
                 new Movie
                 {
                     Id=24,
                     MovieName = "Amy",
                     Genre = "Documentary"
                 },
                 new Movie
                 {
                     Id=25,
                     MovieName = "Gladiator",
                     Genre = "Action"
                 },
                 new Movie
                 {
                     Id=26,
                     MovieName = "Lord Of The Rings",
                     Genre = "Sci-Fi"
                 },
                 new Movie
                 {
                     Id=27,
                     MovieName = "The Departed",
                     Genre = "Crime"
                 },
                 new Movie
                 {
                     Id=28,
                     MovieName = "Slumdog Millionaire",
                     Genre = "Drama"
                 },
                 new Movie
                 {
                     Id=29,
                     MovieName = "12 Years A Slave",
                     Genre = "Biography"
                 },
                 new Movie
                 {
                     Id=30,
                     MovieName = "Forrest Gump",
                     Genre = "Comedy"
                 }
                );
            modelBuilder.Entity<MovieDetail>().HasData(

                new MovieDetail
                {
                    Id = 1,
                    MovieName = "Titanic",
                    WhenMovieStarts = "15:30",
                    AvailableSeats = 73
                },
                new MovieDetail
                {
                    Id = 2,
                    MovieName = "The Hateful Eight",
                    WhenMovieStarts = "20:00",
                    AvailableSeats = 12
                },
                new MovieDetail
                {
                    Id = 3,
                    MovieName = "Catch Me If You Can",
                    WhenMovieStarts = "12:00",
                    AvailableSeats = 55
                },
                 new MovieDetail
                 {
                     Id = 4,
                     MovieName = "The Conjuring",
                     WhenMovieStarts = "21:30",
                     AvailableSeats = 23
                 },
                 new MovieDetail
                 {
                     Id = 5,
                     MovieName = "Tenet",
                     WhenMovieStarts = "18:45",
                     AvailableSeats = 19
                 },
                 new MovieDetail
                 {
                     Id = 6,
                     MovieName = "Min Pappa Marianne",
                     WhenMovieStarts = "19:00",
                     AvailableSeats = 45
                 },
                 new MovieDetail
                 {
                     Id = 7,
                     MovieName = "American Pie",
                     WhenMovieStarts = "20:30",
                     AvailableSeats = 9
                 },
                 new MovieDetail
                 {
                     Id = 8,
                     MovieName = "Parasit",
                     WhenMovieStarts = "22:15",
                     AvailableSeats = 4
                 },
                 new MovieDetail
                 {
                     Id = 9,
                     MovieName = "Mamma Mia!",
                     WhenMovieStarts = "11:00",
                     AvailableSeats = 95
                 },
                 new MovieDetail
                 {
                     Id = 10,
                     MovieName = "Avengers",
                     WhenMovieStarts = "18:30",
                     AvailableSeats = 34
                 },
                 new MovieDetail
                 {
                     Id = 11,
                     MovieName = "Det Sociala Arvet",
                     WhenMovieStarts = "17:45",
                     AvailableSeats = 39
                 },
                 new MovieDetail
                 {
                     Id = 12,
                     MovieName = "The Conjuring 2",
                     WhenMovieStarts = "22:00",
                     AvailableSeats = 10
                 },
                 new MovieDetail
                 {
                     Id = 13,
                     MovieName = "Searching for Sugar Man",
                     WhenMovieStarts = "15:00",
                     AvailableSeats = 37
                 },
                 new MovieDetail
                 {
                     Id = 14,
                     MovieName = "John Wick",
                     WhenMovieStarts = "20:00",
                     AvailableSeats = 5
                 },
                 new MovieDetail
                 {
                     Id = 15,
                     MovieName = "The Invisible Man",
                     WhenMovieStarts = "19:15",
                     AvailableSeats = 44
                 },
                 new MovieDetail
                 {
                     Id = 16,
                     MovieName = "Joker",
                     WhenMovieStarts = "21:00",
                     AvailableSeats = 0
                 },
                new MovieDetail
                {
                    Id = 17,
                    MovieName = "Get Out",
                    WhenMovieStarts = "21:30",
                    AvailableSeats = 20
                },
                new MovieDetail
                {
                    Id = 18,
                    MovieName = "The Revenant",
                    WhenMovieStarts = "16:00",
                    AvailableSeats = 69
                },
                 new MovieDetail
                 {
                     Id = 19,
                     MovieName = "Manchester By The Sea",
                     WhenMovieStarts = "13:00",
                     AvailableSeats = 47
                 },
                 new MovieDetail
                 {
                     Id = 20,
                     MovieName = "La La Land",
                     WhenMovieStarts = "14:45",
                     AvailableSeats = 18
                 },
                 new MovieDetail
                 {
                     Id = 21,
                     MovieName = "The Big Short",
                     WhenMovieStarts = "17:00",
                     AvailableSeats = 78
                 },
                 new MovieDetail
                 {
                     Id = 22,
                     MovieName = "Toy Story",
                     WhenMovieStarts = "13:30",
                     AvailableSeats = 40
                 },
                 new MovieDetail
                 {
                     Id = 23,
                     MovieName = "Three Billboards Outside Ebbing, Missouri",
                     WhenMovieStarts = "18:30",
                     AvailableSeats = 27
                 },
                 new MovieDetail
                 {
                     Id = 24,
                     MovieName = "Amy",
                     WhenMovieStarts = "19:00",
                     AvailableSeats = 33
                 },
                 new MovieDetail
                 {
                     Id = 25,
                     MovieName = "Gladiator",
                     WhenMovieStarts = "20:30",
                     AvailableSeats = 0
                 },
                 new MovieDetail
                 {
                     Id = 26,
                     MovieName = "Lord Of The Rings",
                     WhenMovieStarts = "18:00",
                     AvailableSeats = 15
                 },
                 new MovieDetail
                 {
                     Id = 27,
                     MovieName = "The Departed",
                     WhenMovieStarts = "21:45",
                     AvailableSeats = 53
                 },
                 new MovieDetail
                 {
                     Id = 28,
                     MovieName = "Slumdog Millionaire",
                     WhenMovieStarts = "17:00",
                     AvailableSeats = 73
                 },
                 new MovieDetail
                 {
                     Id = 29,
                     MovieName = "12 Years A Slave",
                     WhenMovieStarts = "18:30",
                     AvailableSeats = 7
                 },
                 new MovieDetail
                 {
                     Id = 30,
                     MovieName = "Forrest Gump",
                     WhenMovieStarts = "15:45",
                     AvailableSeats = 29
                 }
                );
        }
    }
}
