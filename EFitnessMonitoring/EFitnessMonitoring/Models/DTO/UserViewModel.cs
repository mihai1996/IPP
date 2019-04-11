using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFitnessMonitoring.Models.DTO
{
    public class UserViewModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Gen { get; set; }
        public int Virsta { get; set; }
        public string Parola { get; set; }
        public string ConfirmPaorola { get; set; }
        public string Rolul { get; set; }
    }
}