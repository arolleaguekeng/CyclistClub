using CyclistClub.BO;
using CyclistClub.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclistClub.BLL
{
    public class ReservationManager
    {
        ReservationRepository repository;
        public ReservationManager()
        {
            repository = new ReservationRepository();
        }
        public void AddReservation(Reservation reservation)
        {
            repository.Add(reservation);

        }
        public void RemoveReservation(Reservation reservation)
        {
            repository.Delete("reservations", "id_reservation", reservation.Id);
        }
    }
}
