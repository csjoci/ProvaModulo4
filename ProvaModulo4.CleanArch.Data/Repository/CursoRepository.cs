using ProvaModulo4.CleanArch.Domain.Model;
using ProvaModulo4.CleanArch.Domain.Repository;

namespace ProvaModulo4.CleanArch.Data.Repository;

public class CursoRepository : BaseRepository<Curso>, ICursoRepository
{
    public CursoRepository(Context context) : base(context)
    {    
    }
}
