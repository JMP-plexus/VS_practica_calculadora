using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CochesCutresEntity.Models;
namespace CochesCutresEntity.DAL
{
    public class ConcesionarioInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ConcesionarioContext>
    {
        protected override void Seed(ConcesionarioContext context)
        {
            var coches = new List<Coche>
            {
                new Coche{marca="Audi",modelo="Quattro",npuertas=5,color="blanco",kilometros=0,tipovehiculo= "coupé",garantia=12,estastock=true,fotografia="https//=23141.2321"},
                new Coche{marca="Audi",modelo="Q2",npuertas=5,color="negro",kilometros=0,tipovehiculo= "SUV",garantia=12,estastock=true,fotografia="https//=23141.2321"},
                new Coche{marca="Nissan",modelo="Silvia",npuertas=5,color="azul",kilometros=1222,tipovehiculo= "utilitario",garantia=0,estastock=false,fotografia="https//=23141.2321"}  };

            coches.ForEach(s => context.Coches.Add(s));
            context.SaveChanges();

            var clientes = new List<Cliente>
            {
                new Cliente{NIF="23420986Y",nombre="Quattro",apellidos="Eternal",telefono=321786321,direccion="Nahagrande",email="dagaspinchan@eternal.com"},
                new Cliente{NIF="89674424G",nombre="Caleb",apellidos="Rockefeller",telefono=321432421,direccion="Oseiro",email="cabreira@agua.com"},
                new Cliente{NIF="64365873V",nombre="Tomas",apellidos="Mouriño",telefono=312386321,direccion="Vigo",email="tomas@gmail.com"}  };

            clientes.ForEach(s => context.Clientes.Add(s));
            context.SaveChanges();

            var empleados = new List<Empleado>
            {
                new Empleado{NIF="55556666Y",nombre="Orie",apellidos="Litchkers",telefono=321316321,direccion="Tokyo",email="sablepinchan@eternal.com"},
                new Empleado{NIF="11112222C",nombre="Hyde",apellidos="Night",telefono=321432461,direccion="Miyagi",email="hyde@agua.com"},
                new Empleado{NIF="99999999D",nombre="Vatista",apellidos="crimsom",telefono=312386377,direccion="Osaka",email="vatistagems@gmail.com"}  };

            empleados.ForEach(s => context.Empleados.Add(s));
            context.SaveChanges();

            var compraventas = new List<Compraventa>
            {
                new Compraventa{fecha=DateTime.Parse("2005-09-01"),tipo='C',apellidos="Litchkers",telefono=321316321,direccion="Tokyo",email="sablepinchan@eternal.com"},
             

            compraventas.ForEach(s => context.Compraventas.Add(s));
            context.SaveChanges();
        }
    }
}
