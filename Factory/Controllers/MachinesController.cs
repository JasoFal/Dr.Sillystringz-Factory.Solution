using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly FactoryContext _db;
  
    public MachinesController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Machine> model = _db.Machines.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Machine machine)
    {
      if (!ModelState.IsValid)
      {
        return View(machine);
      }
      else
      {
        _db.Machines.Add(machine);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }

    
    public ActionResult Details(int id)
    {
      Machine thisMachine = _db.Machines
        .Include(e => e.JoinEntities)
        .ThenInclude(j => j.Engineer)
        .FirstOrDefault(e => e.MachineId == id);
      return View(thisMachine);
    }

    public ActionResult AddEngineer(int id)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(m => m.MachineId == id);
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "EngineerName");
      return View(thisMachine);
    }

    [HttpPost]
    public ActionResult AddEngineer(Machine machine, int engineerId)
    {
      #nullable enable
      EngineerMachine? joinEntity = _db.EngineerMachines.FirstOrDefault(j => (j.EngineerId == engineerId && j.MachineId == machine.MachineId));
      #nullable disable
      if (joinEntity == null && engineerId != 0)
      {
        _db.EngineerMachines.Add(new EngineerMachine() { EngineerId = engineerId, MachineId = machine.MachineId });
        _db.SaveChanges();
      }
      return RedirectToAction("Details", new { id = machine.MachineId });
    }

    public ActionResult Edit(int id)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(m => m.MachineId == id);
      return View(thisMachine);
    }

    [HttpPost]
    public ActionResult Edit(Machine machine)
    {
      if (!ModelState.IsValid)
      {
        return View(machine);
      }
      else
      {
        _db.Machines.Update(machine);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }

    public ActionResult Delete(int id)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(m => m.MachineId == id);
      return View(thisMachine);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(m => m.MachineId == id);
      _db.Machines.Remove(thisMachine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteJoin(int joinId)
    {
      EngineerMachine joinEntry = _db.EngineerMachines.FirstOrDefault(e => e.EngineerMachineId == joinId);
      _db.EngineerMachines.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
