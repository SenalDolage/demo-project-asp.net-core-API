using AssesmentAPI.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssesmentAPI.Services
{
    public class ProjectService
    {
        public readonly IMongoCollection<Project> _projects;

        public ProjectService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _projects = database.GetCollection<Project>(settings.ProjectsCollectionName);
        }

        // Get all Projects
        public List<Project> GetProjects() => _projects.Find(project => true).ToList();

        // Get Project by Id
        public Project GetSingleProject(int id) => _projects.Find(project => project.projectId == id).FirstOrDefault();

        // Create new Project
        public void Create(Project proj) => _projects.InsertOne(proj);

        // Update a Project
        public void Update(int id, Project updatedProject) => _projects.FindOneAndUpdate(Builders<Project>.Filter.Eq("projectId", id), Builders<Project>.Update.Set("Name", updatedProject.Name).Set("Description", updatedProject.Description).Set("Venue", updatedProject.Venue));

        // Delete a Project
        public void Delete(int id) => _projects.DeleteOne(project => project.projectId == id);  
    }
}
