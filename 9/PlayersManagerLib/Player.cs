using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersManagerLib
{
    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public int NoOfMatches { get; set; }
        public Player(string name,int age,string country,int noOfMatches)
        {
            Name = name;
            Age = age;
            Country = country;
            NoOfMatches = noOfMatches;
        }
        public static Player RegisterNewPlayer(string name,IPlayerMapper playerMapper = null)
        {
            if (playerMapper == null)
            {
                playerMapper = new PlayerMapper();
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Player's name can not be empty!");
            }
            if (playerMapper.IsPlayerNameExistsInDb(name))
            {
                throw new ArgumentException("Player name already exists");
            }
            playerMapper.AddNewPlayerIntoDb(name);
            return new Player(name, 23, "India", 30);
        }
    }
}
