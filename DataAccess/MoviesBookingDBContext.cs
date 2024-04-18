using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoviesBooking.Models;

namespace MoviesBooking.DataAccess
{
    public class MoviesBookingDBContext : IdentityDbContext<UserInfo>
    {
        public MoviesBookingDBContext(DbContextOptions<MoviesBookingDBContext> options) : base(options) 
        { 
        }


        public DbSet<UserInfo> Users {  get; set; }
        public DbSet<TheatreRoom> TheatreRooms { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<TicketDetail> TicketDetail { get; set; }
        public DbSet<FilmCategory> FilmCategory { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<FilmSchedule> FilmsSchedule { get; set; }
        public DbSet<PremiereTime> PremiereTime { get; set;}
        public DbSet<Theatre> Theatres { get; set; }
        public DbSet<Receipt> Receipt { get; set; }
        public DbSet<ReceiptDetail > ReceiptDetail { get; set; }

    }
}
