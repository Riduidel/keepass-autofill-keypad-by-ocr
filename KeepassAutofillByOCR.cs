using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KeePass.Plugins;

namespace KeepassAutofillByOCR
{
	public sealed class KeepassAutofillByOCRExt : Plugin
	{
		private IPluginHost m_host = null;

		/**
		 * TODO overwrite with some GitHub url (see https://keepass.info/help/v2_dev/plg_index.html#upd for more details)
		 */
//		public virtual string UpdateUrl { get; }

		public override bool Initialize(IPluginHost host)
		{
			if (host == null) return false;
			m_host = host;
			// Any contribution to Keepass should be done here, I guess
			// Indicates the plugin is correctly loaded
			return true;
		}
	}
}
