using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;


namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    public string MachineName { get; set; }
    public string MachineDetails { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}