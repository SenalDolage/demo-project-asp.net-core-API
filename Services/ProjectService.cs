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
        public Project GetSingleProject(string id) => _projects.Find(project => project.Id == id).FirstOrDefault();

        // Create new Project
        public void Create(Project proj) => _projects.InsertOne(proj);

        // Update a Project
        public void Update(string id, Project updatedProject) => _projects.ReplaceOne(project => project.Id == id, updatedProject);

        // Delete a Project
        public void Delete(string id) => _projects.DeleteOne(project => project.Id == id);  
    }
}
