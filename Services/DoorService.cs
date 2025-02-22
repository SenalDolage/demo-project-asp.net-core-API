﻿using AssesmentAPI.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssesmentAPI.Services
{
    public class DoorService
    {
        public readonly IMongoCollection<Door> _doors;

        public DoorService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _doors = database.GetCollection<Door>(settings.DoorsCollectionName);
        }

        // Get all Doors
        public List<Door> GetDoors() => _doors.Find(door => true).ToList();

        // Get Door by Id
        public Door GetSingleDoor(string id) => _doors.Find(door => door.Id == id).FirstOrDefault();

        // Create new Door
        public void Create(Door door) => _doors.InsertOne(door); 

        // Update a Door
        public void Update(string id, Door updatedDoor) => _doors.ReplaceOne(door => door.Id == id, updatedDoor);

        // Delete a Door
        public void Delete(string id) => _doors.DeleteOne(door => door.Id == id);

    }
}
