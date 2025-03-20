using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteWorthy
{
    public static class SessionManager
    {
        public static int? CurrentUserID { get; set; }
        public static string? CurrentUsername { get; set; }

        public static void ClearSession()
        {
            CurrentUserID = null;
            CurrentUsername = null;
        }
    }

}
