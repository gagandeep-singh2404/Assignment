import {
  Count,
  CountSchema,
  Filter,
  repository,
  Where,
} from '@loopback/repository';
import {
  post,
  param,
  get,
  getFilterSchemaFor,
  getWhereSchemaFor,
  patch,
  put,
  del,
  requestBody,
} from '@loopback/rest';
import {Projects} from '../models';
import {ProjectsRepository} from '../repositories';

export class ProjectsController {
  constructor(
    @repository(ProjectsRepository)
    public projectsRepository : ProjectsRepository,
  ) {}

  @post('/projects', {
    responses: {
      '200': {
        description: 'Projects model instance',
        content: {'application/json': {schema: {'x-ts-type': Projects}}},
      },
    },
  })
  async create(@requestBody() projects: Projects): Promise<Projects> {
    return await this.projectsRepository.create(projects);
  }

  @get('/projects/count', {
    responses: {
      '200': {
        description: 'Projects model count',
        content: {'application/json': {schema: CountSchema}},
      },
    },
  })
  async count(
    @param.query.object('where', getWhereSchemaFor(Projects)) where?: Where,
  ): Promise<Count> {
    return await this.projectsRepository.count(where);
  }

  @get('/projects', {
    responses: {
      '200': {
        description: 'Array of Projects model instances',
        content: {
          'application/json': {
            schema: {type: 'array', items: {'x-ts-type': Projects}},
          },
        },
      },
    },
  })
  async find(
    @param.query.object('filter', getFilterSchemaFor(Projects)) filter?: Filter,
  ): Promise<Projects[]> {
    return await this.projectsRepository.find(filter);
  }

  @patch('/projects', {
    responses: {
      '200': {
        description: 'Projects PATCH success count',
        content: {'application/json': {schema: CountSchema}},
      },
    },
  })
  async updateAll(
    @requestBody() projects: Projects,
    @param.query.object('where', getWhereSchemaFor(Projects)) where?: Where,
  ): Promise<Count> {
    return await this.projectsRepository.updateAll(projects, where);
  }

  @get('/projects/{id}', {
    responses: {
      '200': {
        description: 'Projects model instance',
        content: {'application/json': {schema: {'x-ts-type': Projects}}},
      },
    },
  })
  async findById(@param.path.number('id') id: number): Promise<Projects> {
    return await this.projectsRepository.findById(id);
  }

  @patch('/projects/{id}', {
    responses: {
      '204': {
        description: 'Projects PATCH success',
      },
    },
  })
  async updateById(
    @param.path.number('id') id: number,
    @requestBody() projects: Projects,
  ): Promise<void> {
    await this.projectsRepository.updateById(id, projects);
  }

  @put('/projects/{id}', {
    responses: {
      '204': {
        description: 'Projects PUT success',
      },
    },
  })
  async replaceById(
    @param.path.number('id') id: number,
    @requestBody() projects: Projects,
  ): Promise<void> {
    await this.projectsRepository.replaceById(id, projects);
  }

  @del('/projects/{id}', {
    responses: {
      '204': {
        description: 'Projects DELETE success',
      },
    },
  })
  async deleteById(@param.path.number('id') id: number): Promise<void> {
    await this.projectsRepository.deleteById(id);
  }
}
