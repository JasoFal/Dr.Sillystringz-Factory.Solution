using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;


namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "Engineer Name Can't Be Empty!")]
    public string EngineerName { get; set; }
    [Required(ErrorMessage = "Job Title Can't Be Empty!")]
    public string JobTitle { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}