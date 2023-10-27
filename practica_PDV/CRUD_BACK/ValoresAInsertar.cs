using System;
namespace practica_PDV.CRUD_BACK
{
	public class ValoresAInsertar
	{

        public string valor;
		public bool llevaApostrofes;

		public ValoresAInsertar(string v, bool llevaApostrofes=true)
		{
			this.valor = v;
			this.llevaApostrofes = llevaApostrofes;
		}
	}
}

