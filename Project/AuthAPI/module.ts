import { Module } from '@nestjs/common';
import { AuthModel } from './models/authModel';
import { UsersModel } from './models/userModel';
import { DatabaseContext } from './config/dbContext';

@Module({
  imports: [AuthModel, UsersModel, DatabaseContext],
})
export class AppModule {}
