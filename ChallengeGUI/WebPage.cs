using ChallengeGUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeGUI
{
    public abstract class WebPage<TPage> : Abilities where TPage : new()
    {
        private static readonly Lazy<TPage> _lazyPage = new Lazy<TPage>(() => new TPage());
        public static TPage Instance
        {
            get
            {
                return _lazyPage.Value;
            }
        }
    }
}
