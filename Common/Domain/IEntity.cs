using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{

    public interface IEntity
    {
        string TableName{ get; }
        string Values{ get; }
        object JoinValues { get; set; }
        object JoinCondition { get; set; }
        object UpdateValues { get; set; }
        object UpdateCondition { get; set; }

        List<IEntity> GetReaderList(SqlDataReader reader);
        List<IEntity> GetReaderListJoin(SqlDataReader reader);
    }
}
