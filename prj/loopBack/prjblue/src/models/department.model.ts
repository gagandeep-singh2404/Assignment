import {Entity, model, property} from '@loopback/repository';
import {hasMany} from '@loopback/repository';
import {Projects} from './projects.model';
@model()
export class Department extends Entity {
  @property({
    type: 'number',
    id: true,
  })
  number?: number;

  @property({
    type: 'string',
    required: true,
  })
  name: string;

  @property({
    type: 'string',
  })
  location?: string;

  @hasMany(() => Projects)
  projects?: Projects[];

  constructor(data?: Partial<Department>) {
    super(data);
  }
}
