﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BancoAPIEntidades.entities
{
    [DataContract]
    public class Cliente : Persona
    {
        private int _id;

        private string _apellido;
        private string _direccion;
        private string _DNI;
        private DateTime _fechaNac;
        private string telefono;




        [DataMember(Name = "apellido")]
        public string Ape { get => _apellido; set => _apellido = value; }

        [DataMember(Name = "DNI")]
        public string DNI { get => _DNI; set => _DNI = value; }

        [DataMember(Name = "id")]
        public int id { get => _id; set => _id = value; }

        [DataMember(Name = "direccion")]
        public string Direccion { get => _direccion; set => _direccion = value; }

        [DataMember(Name = "fechaNacimiento")]
        public DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }

        [DataMember(Name = "telefono")]
        public string Telefono { get => telefono; set => telefono = value; }

        public Cliente()
        {

        }

        public override string ToString()
        {
            return string.Format("Cliente {0}, {1}", this._apellido, this._nombre);
        }
    }
}
