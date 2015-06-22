using System.ComponentModel;
using System;

namespace T411.Core
{
    public class Torrent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Seeders { get; set; }
        public string Leechers { get; set; }
        public string Comments { get; set; }
        public string IsVerified { get; set; }
        public DateTime Added { get; set; }
        public string Size { get; set; }
        public string Times_completed { get; set; }
        public string Owner { get; set; }
        public string Categoryname { get; set; }
        public string Categoryimage { get; set; }
        public string Username { get; set; }
        public string Privacy { get; set; }
        public string Rewritename { get; set; }
    }
}
