import {Getter, inject} from '@loopback/core';
import {
  DefaultCrudRepository,
  HasManyRepositoryFactory,
  juggler,
  repository,
} from '@loopback/repository';
import {Projects, Department} from '../models';
import {ProjectsRepository} from './projects.repository';

export class DepartmentRepository extends DefaultCrudRepository<
  Department,
  typeof Department.prototype.number
> {
  public readonly projects: HasManyRepositoryFactory<
  Projects,
    typeof Department.prototype.number
  >;

  constructor(
    @inject('datasources.db') dataSource: juggler.DataSource,
    @repository.getter(ProjectsRepository)
    protected projectRepositoryGetter: Getter<ProjectsRepository>,
  ) {
    super(Department, dataSource);
    this.projects = this.createHasManyRepositoryFactoryFor(
      'projects',
      projectRepositoryGetter,
    );
  }
}
