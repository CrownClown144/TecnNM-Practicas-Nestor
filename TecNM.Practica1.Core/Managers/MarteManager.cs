using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Managers.Interfaces;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Managers;

public class MarteManager : IMarteManager{
    private readonly IMarteServices _service;

    public MarteManager(IMarteServices service){
        _service = service;
    }

    public Marte GetMarte(Person person){
        return _service.ProcessMarte(person);
    }
}