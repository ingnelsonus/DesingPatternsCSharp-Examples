﻿namespace memento.Example1_Persona
{
    public class Memento
    {
        private string _estado;

        public Memento()
        {

        }

        public Memento(string estado)
        {
            _estado = estado;
        }

        public string Estado
        {
            get { return _estado; }
        }

    }
}
