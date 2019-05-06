using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{
    public WebService()
    {
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

    [WebMethod]
    public bool cadastraCliente(String cpf,String nome, String email)
    {
        //Conexão com o Mysql
        MySqlConnection conexao = new MySqlConnection(
            "Server=ESN509VMYSQL;Database=webservice;Uid=aluno;Pwd=Senai1234;SslMode=none");
        String sql = "INSERT INTO cliente VALUES (@cpf,@nome,@email);";

        //Vincula o comando a ser executado com a conexão
        MySqlCommand command = new MySqlCommand(sql, conexao);
        //Passagem de valores para o insert
        command.Parameters.AddWithValue("@cpf", cpf);
        command.Parameters.AddWithValue("@nome", nome);
        command.Parameters.AddWithValue("@email", email);

        conexao.Open();//Abre a conexão

        if (command.ExecuteNonQuery() != 0)
        {
            conexao.Close();
            return true;
        }
        else
        {
            conexao.Close();
            return false;
        }
    }
}
