import {DefaultCrudRepository} from '@loopback/repository';
import {Projects} from '../models';
import {DbDataSource} from '../datasources';
import {inject} from '@loopback/core';

export class ProjectsRepository extends DefaultCrudRepository<
  Projects,
  typeof Projects.prototype.number
> {
  constructor(
    @inject('datasources.db') dataSource: DbDataSource,
  ) {
    super(Projects, dataSource);
  }
}
