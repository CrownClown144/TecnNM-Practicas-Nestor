using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Services;

public class MarteServices : IMarteServices{
    public Marte ProcessMarte(Person person){

        var marte = new Marte();

        marte.PesoMarte = (float)((float)(person.Weigth / 9.81) * 3.711);
        return marte;
    }
}