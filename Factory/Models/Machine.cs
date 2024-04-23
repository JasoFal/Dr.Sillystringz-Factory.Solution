using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;


namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "Machine Name Can't Be Empty")]
    public string MachineName { get; set; }
    [Required(ErrorMessage = "Machine Details Can't Be Empty")]
    public string MachineDetails { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}