using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppCompras.Model;
using SQLite;

namespace AppCompras.Helper
{
    public class SQLiteDatabaseHelper
    {
        readonly SQLiteAsyncConnection _conn;

        public SQLiteDatabaseHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Produto>().Wait();
        }

        public Task<int> insert(Produto p)
        {
            return _conn.InsertAsync(p);
        }

        public void update(Produto p)
        {
            string sql = "UPDATE produto SET descricao=?, quantidade=?, preco=? WHERE id=?";

            _conn.QueryAsync<Produto>(sql, p.descricao, p.quantidade, p.preco, p.id);
        }

        /*public Task<Produto> getById(int id)
        {
            return new Produto();
        }*/

        public Task<List<Produto>> getAll()
        {
            return _conn.Table<Produto>().ToListAsync();
        }

        public Task<int> Delete(int id)
        {
            return _conn.Table<Produto>().DeleteAsync(i => i.id == id);
        }
    }
}
