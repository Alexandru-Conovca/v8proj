using v8proj.BissnessLogic.Interfaces;

namespace v8proj.BissnessLogic
{
    public class BissnessLogic
    {
        public ISession GetSession()
        {
            return new SessionBL();
        }
    }
}