using DataLayer;
using Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BusinessLayer
{
    public class BusinessLayerClass{

        public static List<ModelClass> GetDatafromBusinessLayer(){
            ModelClass _mc = new ModelClass();
            var _list = new List<ModelClass>();
            DataSet _buslayerDataSet = new DataSet();

            _buslayerDataSet = DataLayerClass.GetDatafromDB();


            if(_buslayerDataSet != null){
                _list = _buslayerDataSet.Tables[0].AsEnumerable().Select(m => new ModelClass{
                    book_id = m["book_id"].ToString(),
                    book_name = m["book_name"].ToString(),
                    author = m["author"].ToString(),
                    type = m["type"].ToString(),
                    link = m["link"].ToString(),
                    added_by_id = m["added_by_id"].ToString(),
                    date = m["date"].ToString()
                }).ToList();
            }

            return _list;
        }
    }
}
