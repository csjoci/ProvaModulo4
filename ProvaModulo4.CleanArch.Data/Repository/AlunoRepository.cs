using ProvaModulo4.CleanArch.Domain.Model;
using ProvaModulo4.CleanArch.Domain.Repository;

namespace ProvaModulo4.CleanArch.Data.Repository;

public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
{
    public AlunoRepository(Context context) : base(context)
    {  
    }
}
