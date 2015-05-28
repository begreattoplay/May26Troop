using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Lab10
{
    public interface IMovie
    {
        string Director { get; set; }
        decimal TicketPrice { get; set; }
        string Title { get; set; }
    }

    public class Bladerunner : ActionMovie, IActionMovie, IMovie
    {

    }

    public interface IActionMovie
    {

    }

    public class ScienceFictionMovie : IMovie
    {
        public string Director { get; set; }
        public decimal TicketPrice { get; set; }
        public string Title { get; set; }
    }

    public class ActionMovie : IMovie
    {
        public string Director { get; set; }
        public decimal TicketPrice { get; set; }
        public string Title { get; set; }
    }
}
