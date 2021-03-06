// This file is Part of CalDavSynchronizer (http://outlookcaldavsynchronizer.sourceforge.net/)
// Copyright (c) 2015 Gerhard Zehetbauer
// Copyright (c) 2015 Alexander Nimmervoll
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using CalDavSynchronizer.OAuth.Swisscom;
using CalDavSynchronizer.Ui.Options.Models;
using CalDavSynchronizer.Utilities;

namespace CalDavSynchronizer.ProfileTypes.ConcreteTypes.Swisscom
{
  class SwisscomServerSettingsDetector : IServerSettingsDetector
  {
    private const string APP_KEY = "fArWZ9P9e163dbMzCuzJtCEGa5vKOUBf";
    private const string APP_SECRET = "QVXHXaUwSyVWDyxv";

    public void AutoFillServerSettings(OptionsModel optionsModel)
    {
      var scsOauth = new SwisscomOauth(APP_KEY, APP_SECRET);
      var credentials = scsOauth.GetCredentials();
      optionsModel.UserName = credentials.Username;
      optionsModel.Password = SecureStringUtility.ToSecureString(credentials.Password);
      optionsModel.CalenderUrl = credentials.Url;
    }
  }
}