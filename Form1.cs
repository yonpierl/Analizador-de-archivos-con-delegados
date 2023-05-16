namespace Analizador_de_archivos
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    public delegate bool FiltroExtensionDelegate(string nombreArchivo);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificarRuta_Click(object sender, EventArgs e)
        {
            string rutaDirectorio = txtRutaDirectorio.Text;
            string filtroExtension = txtFiltroExtension.Text;

            FiltroExtensionDelegate filtroDelegate = null;

            if (!string.IsNullOrWhiteSpace(filtroExtension))
            {
                filtroDelegate = (nombreArchivo) => Path.GetExtension(nombreArchivo) == filtroExtension;
            }

            if (Directory.Exists(rutaDirectorio))
            {
                string[] archivos = Directory.GetFiles(rutaDirectorio);

                int totalArchivos = archivos.Length;
                long tamanoTotal = 0;
                long tamanoPromedio = 0;
                string archivoMasGrande = "";
                long tamanoArchivoMasGrande = 0;
                string archivoMasPequeno = "";
                long tamanoArchivoMasPequeno = long.MaxValue;

                foreach (string archivo in archivos)
                {
                    if (filtroDelegate == null || filtroDelegate(archivo))
                    {
                        long tamanoArchivo = new FileInfo(archivo).Length;

                        tamanoTotal += tamanoArchivo;

                        if (tamanoArchivo > tamanoArchivoMasGrande)
                        {
                            tamanoArchivoMasGrande = tamanoArchivo;
                            archivoMasGrande = Path.GetFileName(archivo);
                        }

                        if (tamanoArchivo < tamanoArchivoMasPequeno)
                        {
                            tamanoArchivoMasPequeno = tamanoArchivo;
                            archivoMasPequeno = Path.GetFileName(archivo);
                        }
                    }
                }

                if (totalArchivos > 0)
                {
                    tamanoPromedio = tamanoTotal / totalArchivos;
                }

                string mensaje = $"Número total de archivos: {totalArchivos}\n" +
                                 $"Tamaño total de todos los archivos: {tamanoTotal} bytes\n" +
                                 $"Tamaño promedio de archivo: {tamanoPromedio} bytes\n" +
                                 $"Archivo más grande: {archivoMasGrande} ({tamanoArchivoMasGrande} bytes)\n" +
                                 $"Archivo más pequeño: {archivoMasPequeno} ({tamanoArchivoMasPequeno} bytes)";

                MessageBox.Show(mensaje,
                    "Estadísticas de archivos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La ruta de directorio no es válida o no existe.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}

