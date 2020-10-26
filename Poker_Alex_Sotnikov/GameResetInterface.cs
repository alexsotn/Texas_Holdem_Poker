using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker_Alex_Sotnikov {
	interface GameResetInterface {
		void Unsubscribe(GameControl game);
		void Subscribe(GameControl game);
		void ReInitialize();
	}
}
