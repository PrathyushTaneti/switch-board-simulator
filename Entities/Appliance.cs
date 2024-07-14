using switch_board_simulator.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_board_simulator.Entities
{
    public class Appliance(int id, string name, State state)
    {
        public int Id { get; set; } = id;

        public string Name { get; set; } = name ?? throw new ArgumentNullException(nameof(name));

        public State State { get; set; } = state;
    }
}
