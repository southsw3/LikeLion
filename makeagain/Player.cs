using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makeagain
{
    public class Player
    {
        public INFO m_tInfo;
        public void SetDamge(int iAttack) { m_tInfo.iHp -= iAttack; }
    }
}
