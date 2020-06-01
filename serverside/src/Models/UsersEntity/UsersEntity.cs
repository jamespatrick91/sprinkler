/*
 * @bot-written
 * 
 * WARNING AND NOTICE
 * Any access, download, storage, and/or use of this source code is subject to the terms and conditions of the
 * Full Software Licence as accepted by you before being granted access to this source code and other materials,
 * the terms of which can be accessed on the Codebots website at https://codebots.com/full-software-licence. Any
 * commercial use in contravention of the terms of the Full Software Licence may be pursued by Codebots through
 * licence termination and further legal action, and be required to indemnify Codebots for any loss or damage,
 * including interest and costs. You are deemed to have accepted the terms of the Full Software Licence on any
 * access, download, storage, and/or use of this source code.
 * 
 * BOT WARNING
 * This file is bot-written.
 * Any changes out side of "protected regions" will be lost next time the bot makes any changes.
 */
// users
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Sprinkler.Enums;
using Sprinkler.Security;
using Sprinkler.Validators;
using Microsoft.EntityFrameworkCore;
using Z.EntityFramework.Plus;
// % protected region % [Add any further imports here] off begin
// % protected region % [Add any further imports here] end

namespace Sprinkler.Models {
	/// <summary>
	/// this is a user
	/// </summary>
	// % protected region % [Configure entity attributes here] off begin
	[Table("Users")]
	// % protected region % [Configure entity attributes here] end
	public class UsersEntity : IOwnerAbstractModel
	{
		[Key]
		public Guid Id { get; set; }
		public Guid Owner { get; set; }
		public DateTime Created { get; set; }
		public DateTime Modified { get; set; }

		/// <summary>
		/// test
		/// </summary>
		// % protected region % [Customise Name here] off begin
		[EntityAttribute]
		public String Name { get; set; }
		// % protected region % [Customise Name here] end

		// % protected region % [Add any further attributes here] off begin
		// % protected region % [Add any further attributes here] end

		public UsersEntity() 
		{
			// % protected region % [Add any constructor logic here] off begin
			// % protected region % [Add any constructor logic here] end
		}

		[NotMapped]
		public IEnumerable<IAcl> Acls => new List<IAcl>
		{
			// % protected region % [Add any further ACL entries here] off begin
			// % protected region % [Add any further ACL entries here] end
		};

		public void BeforeSave(EntityState operation, SprinklerDBContext dbContext, IServiceProvider serviceProvider)
		{
			// % protected region % [Add any before save logic here] off begin
			// % protected region % [Add any before save logic here] end
		}

		public void AfterSave(EntityState operation, SprinklerDBContext dbContext, IServiceProvider serviceProvider, ICollection<ChangeState> changes)
		{
			// % protected region % [Add any after save logic here] off begin
			// % protected region % [Add any after save logic here] end
		}

		public int CleanReference<T>(string reference, IEnumerable<T> models, SprinklerDBContext dbContext)
			where T : IOwnerAbstractModel
		{
			var modelList = models.ToList();
			var ids = modelList.Select(t => t.Id).ToList();

			switch (reference)
			{
				// % protected region % [Add any extra clean reference logic here] off begin
				// % protected region % [Add any extra clean reference logic here] end
				default:
					return 0;
			}
		}
		// % protected region % [Add any further references here] off begin
		// % protected region % [Add any further references here] end
	}
}