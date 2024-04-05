namespace Factory.Models
{
  public class EngineerMachine : DbContext
  {
    public int EngineerMachineId { get; set; }
    public int EngineerId { get; set; }
    public int Engineer Engineer { get; set; }
    public int MachineId { get; set; }
    public Machine Machine { get; set; }
  }
}