import {repository} from '@loopback/repository';
import {DepartmentRepository} from '../repositories';
import {post, param, requestBody} from '@loopback/rest';
import {Projects} from '../models';

export class DepartmentProjectsController {
  constructor(
    @repository(DepartmentRepository) protected departmentRepo: DepartmentRepository,
  ) {}

  @post('/todo-lists/{id}/todos')
  async create(@param.path.number('id') id: number, @requestBody() Projects: Projects) {
    return await this.departmentRepo.projects(id).create(Projects);
  }
}