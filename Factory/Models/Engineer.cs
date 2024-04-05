using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;


namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    public string EngineerName { get; set; }
    public string JobTitle { get; set; }
    public DateTime DateOfHire { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}