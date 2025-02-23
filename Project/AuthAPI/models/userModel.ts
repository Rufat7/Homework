import { Module } from '@nestjs/common';
import { UsersService } from './services/userService';
import { UsersController } from './controllers/userController';
import { MongooseModule } from '@nestjs/mongoose';
import { UserSchema } from './schemas/userSchema';

@Module({
  imports: [MongooseModule.forFeature([{ name: 'User', schema: UserSchema }])],
  providers: [UsersService],
  controllers: [UsersController],
  exports: [UsersService],
})
export class UsersModel {}
