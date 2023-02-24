using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaContableOriginal
{
    public class Conectar
    {
        public SqlConnection conn = new SqlConnection();

        public Conectar(String user, String pass)
        {
            try
            {
                conn = new SqlConnection("Server=JADPA-24\\SQLSERVER2019;Database=Contador;UID=" + user + ";PWD=" + pass);
                conn.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("No se conecta al servidor");
            }
        }

        /**/

        public void insertarER(double valor, double a, double b, double cb, double rb, double gv, double ga, double roo, double ingf, double gf, double ingE, double gasE, double ingEjAnt, double gia, double raig, double imp, double rn)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@IngA", SqlDbType.VarChar);
                param[0].Value = valor;
                param[1] = new SqlParameter("@DB", SqlDbType.VarChar);
                param[1].Value = a;
                param[2] = new SqlParameter("@ION", SqlDbType.VarChar);
                param[2].Value = b;
                param[3] = new SqlParameter("@CBV", SqlDbType.VarChar);
                param[3].Value = cb;
                param[4] = new SqlParameter("@RB", SqlDbType.Char);
                param[4].Value = rb;
                param[5] = new SqlParameter("@GV", SqlDbType.VarChar);
                param[5].Value = gv;
                param[6] = new SqlParameter("@GA", SqlDbType.VarChar);
                param[6].Value = ga;
                param[7] = new SqlParameter("@ROO", SqlDbType.VarChar);
                param[7].Value = roo;
                param[8] = new SqlParameter("@IngF", SqlDbType.VarChar);
                param[8].Value = ingf;
                param[9] = new SqlParameter("@GF", SqlDbType.Char);
                param[9].Value = gf;
                param[10] = new SqlParameter("@IngE", SqlDbType.Char);
                param[10].Value = ingE;
                param[11] = new SqlParameter("@GasE", SqlDbType.VarChar);
                param[11].Value = gasE;
                param[12] = new SqlParameter("@IEA", SqlDbType.VarChar);
                param[12].Value = ingEjAnt;
                param[13] = new SqlParameter("@GIA", SqlDbType.VarChar);
                param[13].Value = gia;
                param[14] = new SqlParameter("@RAI", SqlDbType.VarChar);
                param[14].Value = raig;
                param[15] = new SqlParameter("@IG", SqlDbType.Char);
                param[15].Value = imp;
                param[16] = new SqlParameter("@RN", SqlDbType.Char);
                param[16].Value = rn;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertarUsuario";
                cmd.Connection = conn;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la insercion");
                return;
            }



        }
    }
}
