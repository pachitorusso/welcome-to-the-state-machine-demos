﻿using System;

namespace Reservations.Messages.Commands
{
    public class ReserveTicket
    {
        public int TicketId { get; set; }
        public Guid ReservationId { get; set; }
    }
}
