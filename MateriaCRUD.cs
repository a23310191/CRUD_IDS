using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_23310191
{
    public class MateriaCRUD
    {
        private List<Materia> _materias = new List<Materia>();
        private int _ultimoId = 0;

        public Materia CreateMateria(Materia materia)
        {
            materia.ID = ++_ultimoId;
            _materias.Add(materia);
            return materia;
        }

        public List<Materia> GetMaterias()
        {
            return _materias;
        }

        public Materia GetMateriaById(int id)
        {
            return _materias.Find(materia => materia.ID == id);
        }

        public void UpdateMateria(int id, Materia materiaUpdate)
        {
            var materiaActualizar = _materias.FirstOrDefault(materiaIndex => materiaIndex.ID == id);
            if (materiaActualizar != null)
            {
                materiaActualizar.Nombre = materiaUpdate.Nombre;
                materiaActualizar.Profesor = materiaUpdate.Profesor;
            }
        }

        public void DeleteMateria(int id)
        {
            var materiaActualizar = _materias.FirstOrDefault(materiaIndex => materiaIndex.ID == id);
            if (materiaActualizar != null)
            {
                _materias.Remove(materiaActualizar);
            }
        }
    }
}