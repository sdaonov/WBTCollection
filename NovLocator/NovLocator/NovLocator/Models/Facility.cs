using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovLocator.Models
{
	public class Facility
	{

		[JsonProperty(PropertyName = "id")]
		public string Id { get; set; }

		[JsonProperty(PropertyName = "facility_id")]
		public string FacilityId { get; set; }

		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		[JsonProperty(PropertyName = "type")]
		public string Type { get; set; }

		[JsonProperty(PropertyName = "pos")]
		public List<double> Pos { get; set; }

		[JsonProperty(PropertyName = "country")]
		public string Country { get; set; }

		[JsonProperty(PropertyName = "city")]
		public string City { get; set; }

		[JsonProperty(PropertyName = "phone")]
		public string Phone { get; set; }

		[JsonProperty(PropertyName = "division")]
		public string Division { get; set; }

		[JsonProperty(PropertyName = "brand")]
		public string Brand { get; set; }

		[JsonProperty(PropertyName = "strees_address1")]
		public string StreesAddress1 { get; set; }

		[JsonProperty(PropertyName = "strees_address2")]
		public string StreessAddress2 { get; set; }

		[JsonProperty(PropertyName = "mailing_address1")]
		public string MailAddress1 { get; set; }

		[JsonProperty(PropertyName = "mailing_address2")]
		public string MailAddress2 { get; set; }

		[JsonProperty(PropertyName = "zipcode")]
		public string ZipCode { get; set; }

		[JsonProperty(PropertyName = "parsed_phone")]
		public string ParsedPhone { get; set; }

	}
}
