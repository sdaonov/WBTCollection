using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NovLocator.Utilities
{
	internal static class HttpWebRequestExtensions
	{

		internal static Task<WebResponse> GetResponseAsync(this WebRequest request, double milisecondTimeout)
		{

			var timeout = TimeSpan.FromMilliseconds(milisecondTimeout);

			return Task.Factory.StartNew<WebResponse>(() =>
			{
				var t = Task.Factory.FromAsync<WebResponse>(
					request.BeginGetResponse,
					request.EndGetResponse,
					null);

				if (!t.Wait(timeout)) throw new TimeoutException();

				return t.Result;
			});
		}

	}

}
