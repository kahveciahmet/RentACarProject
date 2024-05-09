﻿namespace Core.Entities
{
    public class UserOperationClaim : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

        //Relational properties

        public virtual User User { get; set; }
        public virtual OperationClaim OperationClaim { get; set; }
    }
}
